# LogTimelineTracker



문제 1. 로그 파일은 사이즈, 날짜에 따라 분리된다.

- FileSystemWatcher 지정한 디렉토리의 모든 파일에 대해 파일이 생성되거나 변경되면 함수 호출을 해줍니다. https://yi-chi.tistory.com/90

문제 2. 타임라인 형태의 UI 를 제공하고 같은 시간대의 로그를 보여준다. 

- https://stackoverflow.com/questions/41730087/wpf-scrollable-timeline-control

문제 3. 로그중에 여러줄이 출력되서 포맷에 안맞는 문자열이 존재한다.


추가 1. 최신 로그 파일을 식별하고 꼬리를 따라가야 된다.

추가 2. 유튜브 실시간 방송 처럼 시간대를 이동해서 그대로 흘러가는 기능

추가 3. 실시간으로 다시 이동하는 기능

사실상 항상 꼬리를 보고 있으면 되겠다.

SQLite를 써서 데이터를 저장한다. 데이터를 구조화하고 저장하는데 활용 타임라인을 잘라서 저장해놓을 수 있다.

항상 저장하지는 않는다. 사용자가 원하는 부분만 저장 

https://www.csharpstudy.com/Practical/Prac-sqlite.aspx

https://www.sqlite.org/index.html
