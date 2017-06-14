namespace l2

open Newtonsoft.Json

type Movie = {
    Name : string
    Year: int
}

module Say2 =
    let hello name =
        printfn "Hello %s" name

    let jsonstuff () =

        let movies = [
            { Name = "Bad Boys"; Year = 1995 };
            { Name = "Bad Boys 2"; Year = 2003 }
        ]
    
        let json = JsonConvert.SerializeObject(movies)
        printfn "%s" json
