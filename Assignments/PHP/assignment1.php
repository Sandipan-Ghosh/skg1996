<?php

$n=readLine("command : ");
readline_add_history($n);
 $b=0; $c=0;
  $space = $n - 1;
  for ($c = 1; $c <= $n; $c++)
  {
    for ($b = 1; $b <= $space; $b++)
    {
		echo ' ';
	}
	$space=$space-1;
		for ($b = 1; $b <= 2*$c-1; $b++)
		{
			echo '*';
		}
	echo "\n";
    
 }
   $space=1;
   for ($c =$n-1; $c >=1; $c--)
  {
    for ($b = 1; $b <= $space; $b++)
    {
		echo ' ';
	}
	$space=$space+1;
		for ($b = 1; $b <= 2*$c-1; $b++)
		{
			echo '*';
		}
	echo "\n";
    
 }
?>