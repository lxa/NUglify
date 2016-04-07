// opprec.cs
//
// Copyright 2010 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

//***************************************************************************************
//Used by the Parser to parse expressions
//***************************************************************************************

namespace AjaxMin.JavaScript
{
    public enum OperatorPrecedence
    {
        None,
        Comma,
        Assignment,
        Conditional,
        LogicalOr,
        LogicalAnd,
        BitwiseOr,
        BitwiseXor,
        BitwiseAnd,
        Equality,
        Relational,
        Shift,
        Additive,
        Multiplicative,
        Unary,
        FieldAccess,
        Primary,
        Highest
    }
}

