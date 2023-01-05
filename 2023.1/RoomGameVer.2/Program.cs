namespace RoomGameVer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Any Key ! ");
            Console.ReadKey();



            //플레이어 움직이는 클래스
            Room room = new Room();

            //아직은 정사각형 형태로만 만들 수 있음

            int roomNumY = 3;   //방의 개수y축
            int roomNumX = 3;   //방의 개수x축
            int roomScale = roomNumY * roomNumX;

            int boardSizeY = 11;    //맵크기Y
            int boardSizeX = 11;    //맵크기X

            int thisRoom;

            int[,,] allGameMap = new int[roomScale, boardSizeY, boardSizeX];

            allGameMap = room.MakeMap(allGameMap, boardSizeY, boardSizeX, roomScale);

            int roomNum = room.MainRoomMap(allGameMap, boardSizeY, boardSizeX, roomScale / 2, out thisRoom);
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
                        roomNum = room.UPRoomMap(allGameMap, boardSizeY, boardSizeX, thisRoom - roomNumY, out thisRoom);
                        break;
                    case 2:
                        //오른쪽 방 함수
                        roomNum = room.RightRoomMap(allGameMap, boardSizeY, boardSizeX, thisRoom + 1, out thisRoom);
                        break;
                    case 3:
                        //아래쪽 방 함수
                        roomNum = room.DownRoomMap(allGameMap, boardSizeY, boardSizeX, thisRoom + roomNumY, out thisRoom);
                        break;
                    case 4:
                        //왼쪽방 함수
                        roomNum = room.LeftRoomMap(allGameMap, boardSizeY, boardSizeX, thisRoom - 1, out thisRoom);
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