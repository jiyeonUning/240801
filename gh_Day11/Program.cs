namespace gh_Day11
{
    /* 과제 1. 몬스터 데이터베이스 구현하기
     
               다음의 조건을 충족하는 프로그램을 구현하시오.

      구현 클래스 :
                    MonsterData
                    Monster

               프로그램 시작 시, MonsterData는 몬스터 이름 기준의 string Key 값으로 딕셔너리에 저장한다. (최소 5종류 이상)
               Monster 클래스의 인스턴스 생성 시, 생성자를 사용해 딕셔너리에 저장된 MonsterData 클래스의 정보를 불러와 인스턴스의 데이터를 초기화해야한다.
    */


    public class Program
    {
        static void Main()
        {
            // 메인에 딕셔너리에 저장된 정보를 출력하는 방법을 모르겠음
        }
    }


    public enum MonsterType { Fire, Water, Electric, Nomal, Fairy }

    public class MonsterData // MonsterData 클래스 생성
    {
        public MonsterData(Monster monster)
        {
            // 프로그램 시작시, MonsterData는 몬스터 이름 기준의 string Key 값으로 딕셔너리에 저장 (5종류 이상)
            //  Dictionary<string, Monster> monsterETC = new Dictionary<string, Monster>();  <- 피드백 전 작성한 코드
            static Dictionary<string, Monster> monsterETC = new Dictionary<string, Monster>(); // <- 피드백 반영.                                                                         
            monsterETC.Add("파이리", new Monster("파이리", MonsterType.Fire, 80));     
            monsterETC.Add("울머기", new Monster("울머기", MonsterType.Water, 120));   
            monsterETC.Add("데덴네", new Monster("데덴네", MonsterType.Electric, 30)); //  피드백 받은 내용 :
            monsterETC.Add("이브이", new Monster("이브이", MonsterType.Nomal, 50));    //  몬스터 사전같은 경우, 게임의 시작부터 끝까지 유지되는 데이터로서 볼 수 있습니다.
            monsterETC.Add("님피아", new Monster("님피아", MonsterType.Fairy, 200));   //  즉, 몬스터 딕셔너리를 Static으로 두고 사용한다면 게임의 어디에서든 몬스터의 정보들을 열람하고 활용할 수 있습니다.
        }
    }


    public class Monster // Monster 클래스 생성
    {
        public string name;
        public MonsterType type;
        public int hp;

        // Monster 클래스의 인스턴스 생성 시, 생성자를 사용해
        // 딕셔너리에 저장된 MonsterData 클래스의 정보를 불러와 해당 인스턴스의 데이터를 초기화
        public Monster(string name, MonsterType type, int hp)
        {
            name = "몬스터 이름";
            type = MonsterType.Nomal;
            hp = 100;
        }
    }


}
