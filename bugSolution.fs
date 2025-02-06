let x = 10
let y = 20

let add x y = 
    let mutable x_copy = x
    let mutable y_copy = y
    x_copy <- x_copy + y_copy
    y_copy <- y_copy + x_copy
    x_copy + y_copy

printf "%d %d" (add x y) x 