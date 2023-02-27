using System;

public class Mynode{
    public string key ;

    public int count ;

    public Mynode next;
    public Mynode(String key){
        this.key = key;
        this.count =1;
        this.next = null;

    }

}public class LinkedList{
    public Mynode node ;
    public LinkedList(string Key){
        node = new Mynode(Key);
        
    }

  public void increasecount(){
    node.count++;
  }
  public int getCount(){
    return node.count;
  }
  public string getkey(){
    return node.key;
  }
}

