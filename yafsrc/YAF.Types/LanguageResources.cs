/* Yet Another Forum.NET
 * Copyright (C) 2006-2013 Jaben Cargman
 * http://www.yetanotherforum.net/
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
namespace YAF.Types
{
  #region Using

  using System;
  using System.CodeDom.Compiler;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Xml.Schema;
  using System.Xml.Serialization;

  #endregion

  // This source code was auto-generated by xsd, Version=2.0.50727.3038.

  /// <summary>
  /// The resources.
  /// </summary>
  /// <remarks>
  /// </remarks>
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot("Resources")]
  public class LanguageResources
  {
    #region Constants and Fields

    /// <summary>
    /// The code field.
    /// </summary>
    private string codeField;

    /// <summary>
    /// The language field.
    /// </summary>
    private string languageField;

    /// <summary>
    /// The page field.
    /// </summary>
    private List<LanguageResourcesPage> pageField;

    #endregion

    #region Properties

    /// <summary>
    /// The code.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlAttribute]
    public string code
    {
      get
      {
        return this.codeField;
      }

      set
      {
        this.codeField = value;
      }
    }

    /// <summary>
    /// The language.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlAttribute]
    public string language
    {
      get
      {
        return this.languageField;
      }

      set
      {
        this.languageField = value;
      }
    }

    /// <summary>
    /// The page.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlElement("page", Form = XmlSchemaForm.Unqualified)]
    public List<LanguageResourcesPage> page
    {
      get
      {
        return this.pageField;
      }

      set
      {
        this.pageField = value;
      }
    }

    #endregion
  }

  /// <summary>
  /// The resources page.
  /// </summary>
  /// <remarks>
  /// </remarks>
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class LanguageResourcesPage
  {
    #region Constants and Fields

    /// <summary>
    /// The name field.
    /// </summary>
    private string nameField;

    /// <summary>
    /// The resource field.
    /// </summary>
    private List<LanuageResourcesPageResource> resourceField;

    #endregion

    #region Properties

    /// <summary>
    /// The resource.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlElement("Resource", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
    public List<LanuageResourcesPageResource> Resource
    {
      get
      {
        return this.resourceField;
      }

      set
      {
        this.resourceField = value;
      }
    }

    /// <summary>
    /// The name.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlAttribute]
    public string name
    {
      get
      {
        return this.nameField;
      }

      set
      {
        this.nameField = value;
      }
    }

    #endregion
  }

  /// <summary>
  /// The resources page resource.
  /// </summary>
  /// <remarks>
  /// </remarks>
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  public class LanuageResourcesPageResource
  {
    #region Constants and Fields

    /// <summary>
    /// The edit type field.
    /// </summary>
    private string editTypeField;

    /// <summary>
    /// The tag field.
    /// </summary>
    private string tagField;

    /// <summary>
    /// The value field.
    /// </summary>
    private string valueField;

    #endregion

    #region Properties

    /// <summary>
    /// The value.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlText]
    public string Value
    {
      get
      {
        return this.valueField;
      }

      set
      {
        this.valueField = value;
      }
    }

    /// <summary>
    /// The edit type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlAttribute]
    public string editType
    {
      get
      {
        return this.editTypeField;
      }

      set
      {
        this.editTypeField = value;
      }
    }

    /// <summary>
    /// The tag.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlAttribute]
    public string tag
    {
      get
      {
        return this.tagField;
      }

      set
      {
        this.tagField = value;
      }
    }

    #endregion
  }
}