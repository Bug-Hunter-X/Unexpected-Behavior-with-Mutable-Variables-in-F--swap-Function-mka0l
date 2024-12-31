let x = ref 10
let y = ref 20

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y // Output: 20 10

//Alternative using tuples:

let swapTuple (x, y) = (y, x)

let x, y = swapTuple (10, 20)
printf "%d %d" x y // Output: 20 10