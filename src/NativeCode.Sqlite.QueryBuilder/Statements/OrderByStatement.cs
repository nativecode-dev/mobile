﻿namespace NativeCode.Sqlite.QueryBuilder.Statements
{
    using System.Text;

    public class OrderByStatement : QueryStatement
    {
        public OrderByStatement(EntityTable table) : base("ORDER BY", table)
        {
        }

        public override bool CanBeginStatement(QueryStatement current)
        {
            return current is SelectStatement || current is WhereStatement;
        }

        protected internal override void Prepare(QueryBuilder builder, QueryStatement previous)
        {
        }

        protected internal override void WriteTo(StringBuilder template, QueryStatement parent)
        {
        }
    }
}