namespace Joffrey.FSharp.Lib.MLAI.Clustering

    module Tools =
        
        let findIndexBy (f: 'a -> 'a -> bool) (l: 'a array) =
            match Array.isEmpty l with
            | true -> 0
            | _    ->
                        let mutable i = 0
                        let mutable mi = 0
                    
                        for v in l do
                            if f v l.[mi] then                            
                                mi <- i
                            i <- i + 1
                        mi

