namespace 추상심화실습
{/*클래스 외부에 열거형 자료형 MobType를 하나 만들고 요소로는 Electric, Fire, Water, Grass 를 입력.
그 후, Monster라는 추상 클래스를 구현.
해당 클래스의 맴버 변수로는 정수형 레벨, 열거형 몹타입, 그리고 문자열 이름을 넣어서 구현.
Monster 추상 클래스에 BaseAttack이라는 abstract 메소드도 추가.
    이 Monster 클래스를 상속받는 Pikachu, Squirtle, Bulbasaur, Charmander 네 가지의 클래스를 구현.
Pikachu의 BaseAttack에는 '전광석화', Squirtle는 '물총발사', Bulbasaur는 '덩굴채찍', Charmander는 '화염방사' 를 콘솔에 출력하는 기능을 각각 제작.
각각 몬스터들의 생성자에는 인자값으로 이름과 레벨을 입력받을 수 있게 하고, 몹타입은 본인 취향 적절한 타입을 기입.
    Trainer 클래스에 6개의 몬스터형을 담을 수 있는 배열을 추가하고, 트레이너 생성자에는 자동으로 피카츄를 배열의 첫 번째에 담기게 하는 코드를 작성.
Trainer 클래스의 메소드로는, 몬스터를 인자값으로 받아 추가하는 기능, 그리고 보유중인 모든 몹들이 가진 BaseAttack을 전부 실행하는 AllAttack이라는 메소드를 작성.
마지막으로 메인에서 Trainer를 하나 만든 후, Trainer 객체에 Charmander 한마리를 이름은 '파이리', 레벨은 5로 하여 추가하는 코드를 작성.
Trainer의 AllAttack 메소드를 호출하여 트레이너가 가진 모든 몹의 공격이 콘솔에 출력.
  */
    internal class Program
    {
        public enum MobType { Electric, Fire, Water, Grass, }
        public class Trainer
        {
            public string name;
            public Monster[] monsters = new Monster[6];

            public Trainer(string name)
            {
                this.name = name;
                monsters[0] = new Pikachu(24, MobType.Electric, "피카츄");
                monsters[1] = new Squirtle(30, MobType.Water, "꼬부기");
                monsters[2] = new Bulbasaur(13, MobType.Grass, "이상해씨");
            }

            public void AllAttack(Monster[] monsters)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] == null)
                    {
                        return;
                    }
                    monsters[i].BaseAttack();
                }
            }
        }


        public abstract class Monster
        {
            int level;
            MobType type;
            string name;

            public Monster(int level, MobType type, string name)
            {
                this.level = level;
                this.type = type;
                this.name = name;
            }

            public abstract void BaseAttack();

        }

        public class Pikachu : Monster
        {
            public Pikachu(int level, MobType type, string name) : base(level, type, name)
            {
            }
            public override void BaseAttack()
            {
                Console.WriteLine("전광석화");
            }
        }

        public class Squirtle : Monster
        {
            public Squirtle(int level, MobType type, string name) : base(level, type, name)
            {
            }

            public override void BaseAttack()
            {
                Console.WriteLine("물총발사");
            }
        }

        public class Bulbasaur : Monster
        {
            public Bulbasaur(int level, MobType type, string name) : base(level, type, name)
            {
            }

            public override void BaseAttack()
            {
                Console.WriteLine("덩굴채찍");
            }
        }

        public class Charmander : Monster
        {
            public Charmander(int level, MobType type, string name) : base(level, type, name)
            {
            }

            public override void BaseAttack()
            {
                Console.WriteLine("화염방사");
            }
        }

        static void Main(string[] args)
        {
            Trainer trainer = new Trainer("시연");
            Monster charmander = new Charmander(5, MobType.Fire, "파이리");
            trainer.monsters[3] = charmander;
            trainer.AllAttack(trainer.monsters);

        }
    }
}
