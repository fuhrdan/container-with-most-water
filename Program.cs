int maxArea(int* height, int heightSize) {
    int left = 0;
    int right = heightSize - 1;
    int area = 0;
    int returnArea = 0;
    while (left < right)
    {
//        area = height[left] * height[right];
//        printf("left =  %d, right = %d\n",left, right);
        if(height[left] > height[right])
        {
            area = height[right] * (right - left);
//            printf("Area Calculated l > r = %d\n",area);
        }
        else
        {
            area = height[left] * (right - left);
//            printf("Area Calculated r > l = %d\n",area);
        }
        if (returnArea < area)
        {
            returnArea = area;
        }
        if(height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return returnArea;
/* Lots of crap, starting over
    int maxHeight = 0;
    int maxPos = 0;
    int minHeight = height[0];  // we start with minheight of being 0
    int minPos = 0;
    int testMinPos = 0;
    int testMinHeight = 0;
    int testReturnArea = 0;
    int test2ReturnArea = 0;
    int len = 0;
    int returnArea = 0;
    while(len < heightSize)
    {
        printf("height[%d]=%d and heightSize = %d\n",len,height[len],heightSize);
            if(maxHeight < height[len])
            {
                maxHeight = height[len];
                maxPos = len;
            }
        if(minHeight < height[len])
        {
            if (maxPos != len)
            {
                minHeight = height[len];
                minPos = len;
            }
        }
        // test a return height for all possible variants
        else
        {
            if (maxPos != len)
            {
                testMinHeight = height[len];
                testMinPos = len;
                test2ReturnArea = testMinHeight * ((testMinPos+1) - (maxPos+1));
            }
        }
        printf("Current min = %d, max = %d\n", minPos, maxPos);
        testReturnArea = minHeight * ((minPos+1) - (maxPos+1));
        if(test2ReturnArea > testReturnArea)
        {
            minHeight = testMinHeight;
            minPos = testMinPos;
        }
        len++; // to prevent infinite loop
    }
    returnArea = minHeight * ((minPos+1) - (maxPos+1));
    printf("Return Area = %d\n",returnArea);
    return returnArea;
// Sometimes I leave a lot of "ghost in the shell" old code "just in case"
*/
}