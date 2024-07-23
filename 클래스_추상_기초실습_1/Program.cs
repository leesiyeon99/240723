namespace 클래스_추상_기초실습_1
{
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

