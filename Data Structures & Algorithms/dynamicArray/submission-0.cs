public class DynamicArray {
    
    int[] array;
    int arraySize = 0;
    public DynamicArray(int capacity) {
        array = new int[capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if(array.Length == arraySize)
        {
            Resize();
        }
        array[arraySize] = n;
        arraySize++;
    }

    public int PopBack() {
        int tempVal = array[arraySize-1];
        array[arraySize-1]=0;
        arraySize--;
        return tempVal;
    }

    private void Resize() {
        int[] tempArray = new int[array.Length * 2];
        Array.Copy(array, tempArray, array.Length);
        array = tempArray;
    }

    public int GetSize() {
        return arraySize;
    }

    public int GetCapacity() {
        return array.Length;
    }
}
