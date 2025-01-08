# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates a common misunderstanding in F#: the immutability of functions by default.  Even if you're using mutable variables, the results might not be what you expect if the function doesn't explicitly account for changes to those variables after the initial call.  The solution shows how to address this using a different approach.

## Files:

* `bug.fs`: Shows the buggy code.
* `bugSolution.fs`: Provides a corrected version that addresses the issue.