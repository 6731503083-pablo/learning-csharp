bool binarySearch(int[] arr, int target) {
    
    int low= 0;
        int high = arr.Length;

    do
    {
        int middle = low + (high-low)/2;
        int value = arr[middle];

        if(value == target){
            Console.WriteLine("Found the target value");
            return true;
        }else if(value > target){
            Console.WriteLine("Value is greater than target");
            high = middle;
        }else{
            Console.WriteLine("Value is less than target");
            low = middle + 1;
        }

        
    } while (low < high);

    Console.WriteLine("Target value not found");
    return false;
}

int [] numbers = [1,2,3,4,5];

binarySearch(numbers,65);

