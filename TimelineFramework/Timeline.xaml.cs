using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TimelineFramework
{
    /// <summary>
    /// Interaction logic for Timeline.xaml
    /// </summary>
    public partial class Timeline : UserControl
    {
        List<TimelineMark> TMarks = new List<TimelineMark>();
        List<TimelineElement> TElements = new List<TimelineElement>();
        double innerHeight;
        int elementTop;
        int spacing;
        int startSeconds;
        int endSeconds;
        internal int pixelDistance;

        public Timeline()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new TimelineElement at the desired location (in seconds)
        /// </summary>
        /// <param name="seconds">Position of the element in seconds</param>
        public void AddElement(int seconds)
        {
            TimelineElement te = new TimelineElement(this, innerHeight, seconds);
            TElements.Add(te);
            mainCanvas.Children.Add(te);
            Canvas.SetTop(te, elementTop);
            Canvas.SetLeft(te, (pixelDistance * (seconds - startSeconds) / (endSeconds - startSeconds)) - 2);
        }

        /// <summary>
        /// Called by a TimelineElement once it has finished being dragged to a new location
        /// </summary>
        /// <param name="te">The TimelineElement in question</param>
        public void RefreshElement(TimelineElement te)
        {
            te.SetSeconds((int)((Canvas.GetLeft(te) + 2) * (endSeconds - startSeconds) / pixelDistance) + startSeconds);
        }

        /// <summary>
        /// Sets up the timeline using seconds
        /// </summary>
        /// <param name="startSeconds">How many seconds should be assigned to the left-most side</param>
        /// <param name="endSeconds">How many seconds should be assigned to the right-most side</param>
        /// <param name="intervalSeconds">How many seconds should there be between the visibly marked intervals</param>
        /// <param name="spacing">Distance between intervals in pixels</param>
        public void Setup(int startSeconds, int endSeconds, int intervalSeconds, int spacing)
        {
            this.startSeconds = startSeconds;
            this.endSeconds = endSeconds;
            this.spacing = spacing;

            // Create first mark
            TimelineMark tmStart = new TimelineMark(startSeconds);
            TMarks.Add(tmStart);
            mainCanvas.Children.Add(tmStart);

            // Create middle marks
            int intervalCount = ((endSeconds - startSeconds) / intervalSeconds) - 1;
            for (int i = 1; i <= intervalCount; i++)
            {
                TimelineMark tm = new TimelineMark(startSeconds + (intervalSeconds * i));
                TMarks.Add(tm);
                mainCanvas.Children.Add(tm);
            }

            // Create last mark
            TimelineMark tmEnd = new TimelineMark(endSeconds);
            TMarks.Add(tmEnd);
            mainCanvas.Children.Add(tmEnd);

            // Setup spacing
            for (int k = 0; k < TMarks.Count; k++)
            {
                Canvas.SetLeft(TMarks[k], spacing * k);
                Canvas.SetTop(TMarks[k], 1);
            }

            // Size & place the controls
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;
            Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            //Arrange(new Rect(0, 0, width, height));

            Border border = new Border();
            border.HorizontalAlignment = HorizontalAlignment.Stretch;
            border.VerticalAlignment = VerticalAlignment.Stretch;
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = new SolidColorBrush(Color.FromRgb(12, 12, 12));
            border.Background = new SolidColorBrush(Color.FromRgb(248, 248, 248));
            mainCanvas.Children.Add(border);

            #region tmStart.ActualHeight가 0이 나와서 숫자로 대체
            //Canvas.SetTop(border, 1 + tmStart.ActualHeight);
            //elementTop = 1 + (int)tmStart.ActualHeight + 1; // Canvas.Top value for TimelineElements
            Canvas.SetTop(border, 1 + 24);
            elementTop = 1 + (int)24 + 1; // Canvas.Top value for TimelineElements
            #endregion

            border.Width = 1 + Canvas.GetLeft(tmEnd);
            border.Height = this.ActualHeight - 46; // To account for TimelineMark height & scrollbar height. This value assumes the height of the Aero-style scrollbar.
            innerHeight = this.ActualHeight - 46 - 2; // Height of region inside the border

            pixelDistance = (int)border.Width - 1; // Region of the border aka the timeline's length in pixels
            mainCanvas.Width = (spacing * (TMarks.Count - 1)) + (int)tmEnd.ActualWidth; // Set the canvas's width so the ScrollViewer knows how big it is
        }
    }
}
