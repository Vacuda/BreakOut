
public class LevelInfo
{
    public LevelInfo()
    {
        this.wall_array = new int[74]; // 26, 22, 26

        this.floor_array = new int[195]; //13 each row, 15 rows

        this.spike_array = new int[96]; // 26, 26, 22, 22
    }





    //Start TopLeft, Counter-Clockwise
    public int[] wall_array;

    //Left to Right, Top to Bottom
    public int[] floor_array;

    //Start TopLeft, Clockwise
    public int[] spike_array;


}
