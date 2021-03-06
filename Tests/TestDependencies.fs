namespace Tests
//
open TodoApi.Repositories
open System.Collections.Generic

module TestDependencies =
    let [<Literal>] connectionString = @"Data Source=" + __SOURCE_DIRECTORY__ + @"/Scripts/todotest.db;Version=3"

    let taskRepositoryReader: string -> obj -> IEnumerable<TaskRepository.TaskDto> =  Database.readData connectionString

    let writer: string -> obj -> unit = Database.writeData connectionString