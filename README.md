SampleMVCRoutingProjects
========================

This is a pair of sample projects I am going to use to show how to use a top level controller and Area controller
without the two colliding.

The defaults for both the top-elevl and Admin area are the same, the controller names and indexes are the same, 
and the view names are the same. Everything is cross-linked and there are exmaples of redirecting inside
the same controller scope.

The key ingredients are including the namespace for the top-level route and ensuring Area's are defined as route 
values on all links that intend to cross area boundaries.
