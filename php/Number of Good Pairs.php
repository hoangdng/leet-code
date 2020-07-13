<?php
function numIdenticalPairs($nums)
{
    $array = array_fill(0, 101, -1);
    $totalGoodPairs = 0;
    for ($i = 0; $i < count($nums); $i++)
    {
        $array[$nums[$i]]++;
        if ($array[$nums[$i]] > 0)
        {
            $totalGoodPairs += $array[$nums[$i]];
        }
    }
    return $totalGoodPairs;
}
numIdenticalPairs(array([1, 2, 3, 1, 1, 3]));
