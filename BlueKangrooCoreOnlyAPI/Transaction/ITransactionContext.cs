using System;
using Microsoft.EntityFrameworkCore;
interface ITransactionContext<T>  where T: DbContext
{

    public bool ProcessTransaction(T context);

   

}