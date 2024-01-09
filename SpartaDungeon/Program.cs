using System;

namespace SpartaDungeon
{
   
}
class Store
{
    internal void ShowStr()
    {
        throw new NotImplementedException();
    }
}
class Str
{
    Store store;

    public Str(Store _S)
    {
        store = _S;
    }

    public void ShowStr()
    {
        Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.");
        Console.WriteLine();
        Console.WriteLine("[보유 골드]");
        Console.WriteLine(1500 + "G");
        Console.WriteLine("\n[아이템 목록]");
        Console.WriteLine("- 1 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
        Console.WriteLine("- 2 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
        Console.WriteLine("- 3 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
        Console.WriteLine("- 4 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  구매완료 G");
        Console.WriteLine("- 5 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
        Console.WriteLine("- 6 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
        Console.WriteLine();
        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
        string input = Console.ReadLine();
        return;

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                BuyItem();
                break;

            case "0":
                break;

            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }

        static void BuyItem()
        {
            Console.WriteLine("\n아이템 구매");
            Console.WriteLine("아이템 구매를 선택하면 아이템 목록 앞에 숫자가 표시됩니다.");
            Console.WriteLine("일치하는 아이템을 선택해주세요.");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("구매를 완료했습니.");
                    break;

                case "2":
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    break;

                case "3":
                    Console.WriteLine("Gold가 부족합니다.");
                    break;

                case "4":
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    break;

                case "5":
                    Console.WriteLine("구매를 완료했습니다.");
                    break;

                case "6":
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
class Inventory
{
    public string Armor;
    public string Weapon;
    public Inventory (string armor,string sword, string spear)
    {
        Armor = armor;
        Weapon = sword;
        Weapon = spear;
    }

}
class Inven
{
    Inventory inventory;
    public Inven(Inventory _I)
    {
        inventory = _I;
    }
    public void ShowInven()
    {
        Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine();
        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
        string input = Console.ReadLine();
        return;
    }
}
    class Player
    {
        public string Lv;
        public string Job;
        public int Atk;
        public int Def;
        public int Heath;
        public int Gold;
        //생성자 Class(객체)를 생성하면 자동으로 호출
        public Player(string _lv, string _job, int _atk, int _def, int _heath, int _gold)
        {
            Lv = _lv;
            Job = _job;
            Atk = _atk;
            Def = _def;
            Heath = _heath;
            Gold = _gold;
        }
    }
    class Status
    {
        Player player;
        public Status(Player _p)
        {
            player = _p;
        }
        public void ShowStatus()
        {
            Console.WriteLine("상태 보기\n캐릭터의 정보가 표시 됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. : " + player.Lv);
            Console.WriteLine("직업  : " + player.Job);
            Console.WriteLine("공격력 : " + player.Atk);
            Console.WriteLine("방어력 : " + player.Def);
            Console.WriteLine("체력  : " + player.Heath);
            Console.WriteLine("Gold : " + player.Gold + "G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기 ");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            Player player = new Player("01", "W", 10, 5, 100, 1500);
            Status status = new Status(player);
            Inventory inventory = new Inventory("무쇠갑옷","낡은 검","스파르타의 창");
            Inven inven = new Inven(inventory);
            Store store = new Store();
            Str str = new Str(store);

        while (!gameOver)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("0. 나가기\n");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        status.ShowStatus();
                        break;
                    case "2":
                        Console.Clear();
                        inven.ShowInven();
                        break;
                    case "3":
                        Console.Clear();
                    store.ShowStr();
                        break;
                    case "0":
                        Console.Clear();
                        gameOver = true;
                        break;
                    default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
                }
            }
        }
    }

