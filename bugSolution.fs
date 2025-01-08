let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y

printf "%d" z

//Update values
x := 15
y := 25

printf "%d %d" !x !y

let z2 = add x y

printf "%d" z2