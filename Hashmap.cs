using System ;

class HashMap{
    public List<LinkedList> list ;
     public String [] input_list;
     public Mynode node;
     
     public HashMap(string Settence){
          
     input_list = Settence.Split(" ");
     list = new List<LinkedList>(input_list.Length);
     for(int i= 0 ;i<input_list.Length;i++){
          list.Add(null);
     }
      foreach(string item in input_list){
         Add(item);
      }
    
     }

     public  int _hash(string word){
          int hash = 0;
          string lowerWord = word.ToLower();
          hash = Math.Abs(lowerWord.GetHashCode())%input_list.Length;
          return hash;
     }

     private  void Add(string key){
     int index = _hash(key);
     if(list[index] !=null ){
          list[index].increasecount();
     }else{
          list[index] = new LinkedList(key);

     }
}

public int get(string key){
     int index = _hash(key);
     if(list[index]==null){
          return 0;
     }
     else{
          return list[index].getCount();
     }
}

public void Display(){
     foreach(LinkedList item in list){
          if(item != null){
          Console.WriteLine("The word '{0}' occurs {1}",item.getkey(),item.getCount());
          }
     }
}
}