This repository contains an example of a common error in F#: unexpected side effects due to mutable variables in function calls.

The `bug.fs` file shows the erroneous code, which modifies the input variables within the `add` function, resulting in an output that is not intuitive. 

The `bugSolution.fs` demonstrates how to fix this issue by using immutable variables or passing copies of mutable variables to the function, avoiding side effects and ensuring predictable results.