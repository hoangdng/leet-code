<?php
function runningSum($nums)
{
    for ($i = 1; $i < count($nums); $i++)
    {
        $nums[$i] += $nums[$i - 1];
    }
    return $nums;
}
runningSum(array(1, 1, 1, 1));
