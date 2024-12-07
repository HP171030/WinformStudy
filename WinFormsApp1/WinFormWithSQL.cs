namespace WinFormsApp1
{
  /*
   * C# => MySQL에 연결했다면 다시 해제(Dispose)해야한다.
   * 
   * using(MySqlConnection conn = new MySqlConnection())
   * {}
   * 
   * using을 사용하게되면 using구문이 끝날 때 자동으로 dispose해준다
   * 
   * MySqlCommand cmd = new MySqlCommand("Query문",conn);
   * 해당 클래스를 사용해서 C#에서도 커넥션에 해당하는 위치에 쿼리를 날릴 수 있도록 준비할 수 있다.
   * 해당 클래스에는 ExcuteNonQuery와 ExcuteQuery라는 함수가 있는데
   * 
   * ExcuteNonQuery - DB에 변경하는 명령을 실행할 때 사용한다 리턴값은 변경된 행의 수이다.
   * 
   * ExcuteQuery - DB를 조회하는 명령을 실행할 때 사용한다 MySqlDataReader를 반환한다.
   * DataReader를 통해서 조회된 db에 접근 할 수 있다.
   * 

    */
}
