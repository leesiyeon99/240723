namespace 클래스_상속_기초실습
{
    internal class Program
    {
        class Poketmon
        {
            protected string name;
            protected string type;
            protected int attack;
            protected int hp;


            public virtual void Attack()
            {
                Console.WriteLine($"{type}타입의 {name}가 공격했습니다.");
            }

            public void Run()
            {
                Console.WriteLine($"{name}가 도망쳤습니다.");
            }

            public virtual void Skill()
            {
                Console.WriteLine($"{name}가 스킬을 사용했습니다.");
            }


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
                base.Attack();
                Console.WriteLine("피카츄!");
            }

            public override void Skill()
            {
                base.Skill();
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
                base.Attack();
                Console.WriteLine("파이파이!");
            }

            public override void Skill()
            {
                base.Skill();
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
                base.Attack();
                Console.WriteLine("꼬북꼬북!");
            }

            public override void Skill()
            {
                base.Skill();
                Console.WriteLine("폭포오르기!!!!");
            }
        }


        static void Main(string[] args)
        {
            Poketmon pikachu = new Pikachu();
            Poketmon charmander = new Charmander();
            Poketmon squirtle = new Squirtle();
            pikachu.Attack();
            pikachu.Run();
            charmander.Attack();
            squirtle.Attack();
            charmander.Skill();
            squirtle.Skill();
        }
    }
}
