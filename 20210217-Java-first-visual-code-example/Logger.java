import java.util.*;

public class logger {

    List<String> messages;
    String msgDelim = " --- ";

    public logger() {
        messages = new ArrayList<String>(0);
    }

    public void log(String message){
        Date now = new Date();
        messages.add(now.toString() + msgDelim + message);
    }

    public void displayLastMessage(){
        if (messages.isEmpty()){
            System.out.println("No messages in the logger.");
        } else {
            System.out.println(messages.get(messages.size()-1));
        }
    }

    public void displayAllMessages(){
        for(String item : messages){
            System.out.println(item);
        }
    }
    
}
