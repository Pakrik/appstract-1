﻿#region Copyright (C) 2009-2010 Simon Allaeys

/*
    Copyright (C) 2009-2010 Simon Allaeys
 
    This file is part of AppStract

    AppStract is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    AppStract is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with AppStract.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.Serialization;

namespace AppStract.Engine
{
  /// <summary>
  /// Represents errors that occur in the virtualization engine.
  /// </summary>
  [Serializable]
  public class EngineException : Exception
  {

    #region Constructors

    public EngineException()
    { }

    public EngineException(string message)
      : base(message)
    { }

    public EngineException(string message, Exception innerException)
      : base (message, innerException)
    { }

    protected EngineException(SerializationInfo info, StreamingContext ctxt)
      : base(info, ctxt) { }

    #endregion

  }
}
