//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 29/01/2012 10:07:42 PM
namespace WebApplication2.NorthwindService
{
    
    /// <summary>
    /// There are no comments for DemoService in the schema.
    /// </summary>
    public partial class DemoService : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new DemoService object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public DemoService(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("ODataDemo", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("WebApplication2.NorthwindService", typeName.Substring(9)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("WebApplication2.NorthwindService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("ODataDemo.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("Products");
                }
                return this._Products;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Product> _Products;
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Category> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Category>("Categories");
                }
                return this._Categories;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Category> _Categories;
        /// <summary>
        /// There are no comments for Suppliers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Supplier> Suppliers
        {
            get
            {
                if ((this._Suppliers == null))
                {
                    this._Suppliers = base.CreateQuery<Supplier>("Suppliers");
                }
                return this._Suppliers;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Supplier> _Suppliers;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
        /// <summary>
        /// There are no comments for Suppliers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSuppliers(Supplier supplier)
        {
            base.AddObject("Suppliers", supplier);
        }
    }
    /// <summary>
    /// There are no comments for ODataDemo.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Product
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="releaseDate">Initial value of ReleaseDate.</param>
        /// <param name="rating">Initial value of Rating.</param>
        /// <param name="price">Initial value of Price.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Product CreateProduct(int ID, global::System.DateTime releaseDate, int rating, decimal price)
        {
            Product product = new Product();
            product.ID = ID;
            product.ReleaseDate = releaseDate;
            product.Rating = rating;
            product.Price = price;
            return product;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ReleaseDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime ReleaseDate
        {
            get
            {
                return this._ReleaseDate;
            }
            set
            {
                this.OnReleaseDateChanging(value);
                this._ReleaseDate = value;
                this.OnReleaseDateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _ReleaseDate;
        partial void OnReleaseDateChanging(global::System.DateTime value);
        partial void OnReleaseDateChanged();
        /// <summary>
        /// There are no comments for Property DiscontinuedDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> DiscontinuedDate
        {
            get
            {
                return this._DiscontinuedDate;
            }
            set
            {
                this.OnDiscontinuedDateChanging(value);
                this._DiscontinuedDate = value;
                this.OnDiscontinuedDateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _DiscontinuedDate;
        partial void OnDiscontinuedDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnDiscontinuedDateChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Rating;
        partial void OnRatingChanging(int value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Category Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this._Category = value;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Category _Category;
        /// <summary>
        /// There are no comments for Supplier in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier;
            }
            set
            {
                this._Supplier = value;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Supplier _Supplier;
    }
    /// <summary>
    /// There are no comments for ODataDemo.Category in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Category
    {
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Category CreateCategory(int ID)
        {
            Category category = new Category();
            category.ID = ID;
            return category;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Collections.ObjectModel.Collection<Product> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                if ((value != null))
                {
                    this._Products = value;
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Collections.ObjectModel.Collection<Product> _Products = new global::System.Collections.ObjectModel.Collection<Product>();
    }
    /// <summary>
    /// There are no comments for ComplexType ODataDemo.Address in the schema.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this._Street = value;
                this.OnStreetChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property ZipCode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ZipCode
        {
            get
            {
                return this._ZipCode;
            }
            set
            {
                this.OnZipCodeChanging(value);
                this._ZipCode = value;
                this.OnZipCodeChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ZipCode;
        partial void OnZipCodeChanging(string value);
        partial void OnZipCodeChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
    }
    /// <summary>
    /// There are no comments for ODataDemo.Supplier in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("ID")]
    public partial class Supplier
    {
        /// <summary>
        /// Create a new Supplier object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        /// <param name="address">Initial value of Address.</param>
        /// <param name="concurrency">Initial value of Concurrency.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Supplier CreateSupplier(int ID, Address address, int concurrency)
        {
            Supplier supplier = new Supplier();
            supplier.ID = ID;
            if ((address == null))
            {
                throw new global::System.ArgumentNullException("address");
            }
            supplier.Address = address;
            supplier.Concurrency = concurrency;
            return supplier;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Address Address
        {
            get
            {
                if (((this._Address == null) 
                            && (this._AddressInitialized != true)))
                {
                    this._Address = new Address();
                    this._AddressInitialized = true;
                }
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this._Address = value;
                this._AddressInitialized = true;
                this.OnAddressChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Address _Address;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _AddressInitialized;
        partial void OnAddressChanging(Address value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property Concurrency in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Concurrency
        {
            get
            {
                return this._Concurrency;
            }
            set
            {
                this.OnConcurrencyChanging(value);
                this._Concurrency = value;
                this.OnConcurrencyChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Concurrency;
        partial void OnConcurrencyChanging(int value);
        partial void OnConcurrencyChanged();
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Collections.ObjectModel.Collection<Product> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                if ((value != null))
                {
                    this._Products = value;
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Collections.ObjectModel.Collection<Product> _Products = new global::System.Collections.ObjectModel.Collection<Product>();
    }
}