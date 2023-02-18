
public class LevelInfo
{
    public LevelInfo()
    {
        this.wall_array = new int[82]; // 26, 30, 26

        this.floor_array = new int[255]; //17 each row, 15 rows

        this.spike_array = new int[112]; // 30, 26, 30, 26
    }





    //Start TopLeft, Counter-Clockwise
    public int[] wall_array;

    //Left to Right, Top to Bottom
    public int[] floor_array;

    //Start TopLeft, Counter-Clockwise
    public int[] spike_array;


    /* UTILITIES */

    public void Remove_Spikes_AroundDoors(int index)
    {
        spike_array[index] = 0;
        spike_array[index + 1] = 0;
        spike_array[index + 2] = 0;
        spike_array[index + 3] = 0;
    }

}
