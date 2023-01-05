namespace RoomGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //플레이어 움직이는 클래스
            Character player = new Character();
            Room room = new Room();


            int roomNumY = 5;
            int roomNumX = 5;

            int roomScale = roomNumY * roomNumX;
            int boardSizeY = 21;
            int boardSizeX = 21;

            int[,,] allGameMap = new int[roomScale, boardSizeY, boardSizeX];


            int roomNum = room.MainRoomMap(boardSizeY, boardSizeX);
            bool playerLife = true;

            while (playerLife)
            {
                switch (roomNum)
                {
                    case 0:     //게임종료
                        playerLife = false;
                        break;
                    case 1:     //위쪽방
                        //위쪽방 함수
                        roomNum = room.UPRoomMap(boardSizeY, boardSizeX);
                        break;
                    case 2:
                        //오른쪽 방 함수
                        roomNum = room.RightRoomMap(boardSizeY, boardSizeX);
                        break;
                    case 3:
                        //아래쪽 방 함수
                        roomNum = room.DownRoomMap(boardSizeY, boardSizeX);
                        break;
                    case 4:
                        //왼쪽방 함수
                        roomNum = room.LeftRoomMap(boardSizeY, boardSizeX);
                        break;
                    default:
                        break;


                }

            }       //loop: 플레이어 생명


            //게임종료
            Console.Clear();
            Console.WriteLine("게임 오버!");
        }       // Main()
    }       // class Program
}