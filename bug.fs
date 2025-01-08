let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d" z

x <- 15
y <- 25

printf "%d %d" x y

let z2 = add x y

printf "%d" z2 // z2 will not be updated to reflect the changed values of x and y because F# functions are immutable by default.