import java.util.*;

class First {
    public static void main(String[] args){

        logger loggerInst = new logger();

        loggerInst.log("Hello world!");
        loggerInst.log("Really, hello...");
        loggerInst.displayLastMessage();

        Integer[] toEducateArrays = new Integer[] {7,1,2,11,3,5,13};
        List<Integer> toEducateLists = Arrays.asList(toEducateArrays);

        for (int index=0; index<toEducateArrays.length; index++){
            loggerInst.log(toEducateArrays[index].toString());
        }

        Collections.sort(toEducateLists);
        for (Integer item:toEducateLists){
            loggerInst.log(item.toString());
        }

        loggerInst.displayAllMessages();        
    }
}