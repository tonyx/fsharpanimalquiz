
module fsharpAnimalQuizKata.MainModule
open fsharpAnimalQuizKata.RunModule
open fsharpAnimalQuizKata.IoModule
open fsharpAnimalQuizKata.BrainModule
open System
open fsharpAnimalQuizKata.RecordUtils


[<EntryPoint>]
    let main argv =

        let myOutputStream = new ConsoleOutput() :> OutStream
        let myInputStream = new ConsoleInput() :> InStream

        let tree = AnimalName "elephant"
        runForever myOutputStream myInputStream tree Welcome

