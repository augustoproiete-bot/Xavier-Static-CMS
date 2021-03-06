﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SqlMapper.EntityFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class tempdbEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new tempdbEntities1 object using the connection string found in the 'tempdbEntities1' section of the application configuration file.
        /// </summary>
        public tempdbEntities1() : base("name=tempdbEntities1", "tempdbEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new tempdbEntities1 object.
        /// </summary>
        public tempdbEntities1(string connectionString) : base(connectionString, "tempdbEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new tempdbEntities1 object.
        /// </summary>
        public tempdbEntities1(EntityConnection connection) : base(connection, "tempdbEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Post> Posts
        {
            get
            {
                if ((_Posts == null))
                {
                    _Posts = base.CreateObjectSet<Post>("Posts");
                }
                return _Posts;
            }
        }
        private ObjectSet<Post> _Posts;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Posts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPosts(Post post)
        {
            base.AddObject("Posts", post);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="tempdbModel", Name="Post")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Post : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Post object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="text">Initial value of the Text property.</param>
        /// <param name="creationDate">Initial value of the CreationDate property.</param>
        /// <param name="lastChangeDate">Initial value of the LastChangeDate property.</param>
        public static Post CreatePost(global::System.Int32 id, global::System.String text, global::System.DateTime creationDate, global::System.DateTime lastChangeDate)
        {
            Post post = new Post();
            post.Id = id;
            post.Text = text;
            post.CreationDate = creationDate;
            post.LastChangeDate = lastChangeDate;
            return post;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, false, "Text");
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                OnCreationDateChanging(value);
                ReportPropertyChanging("CreationDate");
                _CreationDate = StructuralObject.SetValidValue(value, "CreationDate");
                ReportPropertyChanged("CreationDate");
                OnCreationDateChanged();
            }
        }
        private global::System.DateTime _CreationDate;
        partial void OnCreationDateChanging(global::System.DateTime value);
        partial void OnCreationDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastChangeDate
        {
            get
            {
                return _LastChangeDate;
            }
            set
            {
                OnLastChangeDateChanging(value);
                ReportPropertyChanging("LastChangeDate");
                _LastChangeDate = StructuralObject.SetValidValue(value, "LastChangeDate");
                ReportPropertyChanged("LastChangeDate");
                OnLastChangeDateChanged();
            }
        }
        private global::System.DateTime _LastChangeDate;
        partial void OnLastChangeDateChanging(global::System.DateTime value);
        partial void OnLastChangeDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter1
        {
            get
            {
                return _Counter1;
            }
            set
            {
                OnCounter1Changing(value);
                ReportPropertyChanging("Counter1");
                _Counter1 = StructuralObject.SetValidValue(value, "Counter1");
                ReportPropertyChanged("Counter1");
                OnCounter1Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter1;
        partial void OnCounter1Changing(Nullable<global::System.Int32> value);
        partial void OnCounter1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter2
        {
            get
            {
                return _Counter2;
            }
            set
            {
                OnCounter2Changing(value);
                ReportPropertyChanging("Counter2");
                _Counter2 = StructuralObject.SetValidValue(value, "Counter2");
                ReportPropertyChanged("Counter2");
                OnCounter2Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter2;
        partial void OnCounter2Changing(Nullable<global::System.Int32> value);
        partial void OnCounter2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter3
        {
            get
            {
                return _Counter3;
            }
            set
            {
                OnCounter3Changing(value);
                ReportPropertyChanging("Counter3");
                _Counter3 = StructuralObject.SetValidValue(value, "Counter3");
                ReportPropertyChanged("Counter3");
                OnCounter3Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter3;
        partial void OnCounter3Changing(Nullable<global::System.Int32> value);
        partial void OnCounter3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter4
        {
            get
            {
                return _Counter4;
            }
            set
            {
                OnCounter4Changing(value);
                ReportPropertyChanging("Counter4");
                _Counter4 = StructuralObject.SetValidValue(value, "Counter4");
                ReportPropertyChanged("Counter4");
                OnCounter4Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter4;
        partial void OnCounter4Changing(Nullable<global::System.Int32> value);
        partial void OnCounter4Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter5
        {
            get
            {
                return _Counter5;
            }
            set
            {
                OnCounter5Changing(value);
                ReportPropertyChanging("Counter5");
                _Counter5 = StructuralObject.SetValidValue(value, "Counter5");
                ReportPropertyChanged("Counter5");
                OnCounter5Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter5;
        partial void OnCounter5Changing(Nullable<global::System.Int32> value);
        partial void OnCounter5Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter6
        {
            get
            {
                return _Counter6;
            }
            set
            {
                OnCounter6Changing(value);
                ReportPropertyChanging("Counter6");
                _Counter6 = StructuralObject.SetValidValue(value, "Counter6");
                ReportPropertyChanged("Counter6");
                OnCounter6Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter6;
        partial void OnCounter6Changing(Nullable<global::System.Int32> value);
        partial void OnCounter6Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter7
        {
            get
            {
                return _Counter7;
            }
            set
            {
                OnCounter7Changing(value);
                ReportPropertyChanging("Counter7");
                _Counter7 = StructuralObject.SetValidValue(value, "Counter7");
                ReportPropertyChanged("Counter7");
                OnCounter7Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter7;
        partial void OnCounter7Changing(Nullable<global::System.Int32> value);
        partial void OnCounter7Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter8
        {
            get
            {
                return _Counter8;
            }
            set
            {
                OnCounter8Changing(value);
                ReportPropertyChanging("Counter8");
                _Counter8 = StructuralObject.SetValidValue(value, "Counter8");
                ReportPropertyChanged("Counter8");
                OnCounter8Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter8;
        partial void OnCounter8Changing(Nullable<global::System.Int32> value);
        partial void OnCounter8Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Counter9
        {
            get
            {
                return _Counter9;
            }
            set
            {
                OnCounter9Changing(value);
                ReportPropertyChanging("Counter9");
                _Counter9 = StructuralObject.SetValidValue(value, "Counter9");
                ReportPropertyChanged("Counter9");
                OnCounter9Changed();
            }
        }
        private Nullable<global::System.Int32> _Counter9;
        partial void OnCounter9Changing(Nullable<global::System.Int32> value);
        partial void OnCounter9Changed();

        #endregion

    }

    #endregion

}
