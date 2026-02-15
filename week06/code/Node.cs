public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1


        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        //TODO start problem 2 
        if(value == Data)
        {
            return true;
        }
        else if(value < Data)
        {
            if(Left is null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else if (value > Data)
        {
            if(Right is null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
        return false;
    }

    public int GetHeight(List<int>? heights = null, int? count = null)
    {
        if (heights is null)
        {
            heights = new List<int>();
        }
        if (count is null)
        {
            count = 1;
        }
        if(Left is not null)
        {
            count++;
            Left.GetHeight(heights, count); 
            count--;      
        }
        if (Right is not null)
        {
            count++;
            Right.GetHeight(heights, count);   
            count--;         
        }
        if(Left is null && Right is null)
        {
            heights.Add(count.Value);
        }
        return heights.Max(); // Replace this line with the correct return statement(s)
    }
}