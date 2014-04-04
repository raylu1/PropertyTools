﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Window505.xaml.cs" company="PropertyTools">
//   The MIT License (MIT)
//   
//   Copyright (c) 2014 PropertyTools contributors
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary>
//   Interaction logic for Window505.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataGridDemo
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Interaction logic for Window505.xaml
    /// </summary>
    public partial class Window505
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Window505" /> class.
        /// </summary>
        public Window505()
        {
            this.InitializeComponent();

            this.ItemsSource = new ObservableCollection<ObservableCollection<Fruit>>
                                {
                                    new ObservableCollection<Fruit> { Fruit.Apple, Fruit.Banana, Fruit.Orange },
                                    new ObservableCollection<Fruit> { Fruit.Orange, Fruit.Banana, Fruit.Apple },
                                };

            this.RowHeadersItemsSource = new ObservableCollection<string> { "Row I", "Row II" };
            this.ColumnHeadersItemsSource = new ObservableCollection<string> { "Fruit 1", "Fruit 2", "Fruit 3" };

            this.DataContext = this;
        }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public ObservableCollection<ObservableCollection<Fruit>> ItemsSource { get; set; }

        /// <summary>
        /// Gets or sets the row headers items source.
        /// </summary>
        /// <value>
        /// The row headers source.
        /// </value>
        public ObservableCollection<string> RowHeadersItemsSource { get; set; }

        /// <summary>
        /// Gets or sets the column headers items source.
        /// </summary>
        /// <value>
        /// The column headers source.
        /// </value>
        public ObservableCollection<string> ColumnHeadersItemsSource { get; set; }
    }
}