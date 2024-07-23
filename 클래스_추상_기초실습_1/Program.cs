namespace 클래스_추상_기초실습_1
{
    /*
기초과제 2. 오버로딩과 오버라이딩
> 추상클래스의 정의
: 인스턴스화 할 수 없는 특수한 유형의 클래스다. 추상 클래스는 일반적인 구현 클래스와 거의 비슷한 구조이며 상속받는 자식 클래스의 구격을 정해준다. 일반적인 구현 클래스가 추상 클래스가 되려면 반드시 하나 이상의 추상 멤버를 포함해야 한다. 즉 추상 멤버가 하나라도 있으면 추상 클래스가 된다.
참고로 정적 멤버가 하나라도 있는 클래스는 정적 클래스가 아니다. 정적 클래스는 모든 멤버가 정적으로 선언되어 있어야 한다
추상 클래스의 경우 일부는 구현을 포함하고 일부는 자식 클래스에서 반드시 구현하도록 강제 재정의 할 수 있다. 추상 클래스에서 특정 멤버에 abstract키워드를 사용하면 상속받는 자식 클래스에서 멤버를 강제로 재정의해야 한다.
추상 클래스의 추상 멤버의 경우 메서드, 속성, 이벤트, 인덱서만 가능하며 필드는 포함되지 않는다.

> 오버라이딩의 정의
부모가 정의해 둔 함수를 상속받아 재정의하여 사용하는 것을 말한다.(부모 클래스에 있는 메서드를 자식 클래스에서 다시 구현하는 것, 부모 메서드를 덮어씌운다.) 상속받은 자식이 함수의 내용을 바꿔쓰고 싶다면 함수의 이름은 그대로 두되 정의만 바꾸어 사용하면 된다.
기본적으로 오버라이딩을 하기위해서 부모 클래스 메서드는 virtual로 선언되어야 하고, 자식 클래스 메서드는 overrid로 선언되어있어야 한다. 이때 부모 클래스 정보를 잃어버리는 것은 아닌데 이또한 base 키워드로 다시 오버라이딩 된 메서드가 아닌 상속 받은 메서드를 불러 낼 수 있다.

> 오버로딩의 정의
하나의 클래스에 있는 동일한 이름의 여러개의 메서드들을  만들어 사용할 수 있다는 것을 의미한다.
인자가 몇개가 들어오냐에 따라 원하는 생성자를 실행시킬 수 있음
    */
    internal class Program
    {
        public abstract class Poketmon
        {
            protected string name;
            protected string type;
            protected int attack;
            protected int hp;


            public abstract void Attack();
            public void Run()
            {
                Console.WriteLine($"{name}가 도망쳤습니다.");
            }

            public abstract void Skill();

        }

        class Pikachu : Poketmon
        {
            public Pikachu()
            {
                this.name = "피카츄";
                this.type = "전기";
                this.attack = 80;
                this.hp = 200;
            }
            public override void Attack()
            {
                Console.WriteLine($"{type}타입의 {name}가 공격했습니다.");
                Console.WriteLine("피카츄!");
            }

            public override void Skill()
            {
                Console.WriteLine($"{name}가 스킬을 사용했습니다.");
                Console.WriteLine("백만볼트!!!!!");
            }
        }

        class Charmander : Poketmon
        {
            public Charmander()
            {
                this.name = "파이리";
                this.type = "불";
                this.attack = 90;
                this.hp = 300;
            }
            public override void Attack()
            {
                Console.WriteLine($"{type}타입의 {name}가 공격했습니다.");
                Console.WriteLine("파이파이!");
            }

            public override void Skill()
            {
                Console.WriteLine($"{name}가 스킬을 사용했습니다.");
                Console.WriteLine("화염방사!!!");
            }
        }

        class Squirtle : Poketmon
        {
            public Squirtle()
            {
                this.name = "꼬부기";
                this.type = "물";
                this.attack = 50;
                this.hp = 400;
            }
            public override void Attack()
            {
                Console.WriteLine($"{type}타입의 {name}가 공격했습니다.");
                Console.WriteLine("꼬북꼬북!");
            }

            public override void Skill()
            {
                Console.WriteLine($"{name}가 스킬을 사용했습니다.");
                Console.WriteLine("폭포오르기!!!!");
            }
        }


        static void Main(string[] args)
        {
            Poketmon[] poketmons =
            {
                new Squirtle(), new Pikachu(), new Charmander(),
            };

            foreach(var p in poketmons)
            {
                p.Attack();
                p.Skill();
            }
        }
    }
}

