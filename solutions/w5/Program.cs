/*
// See https://aka.ms/new-console-template for more information

+What is a deadlock?
something that happends when 2 or more tasks wait for the resource held by the other.

+What is a semaphore?
like a mutex a resource lock but with a max capacity. 
allows multiple tasks to access a locked resource until one task leaves and there is space for another

+What is a mutex?
a lock that can span tasks (process wide or application wide to system wide)
allows 1 task to lock a resource until its not needed anymore

*/

Console.WriteLine("Hello, World!");