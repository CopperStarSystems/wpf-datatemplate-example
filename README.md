# wpf-datatemplate-example
Simple example of WPF datatemplating, dynamically swapping out UI elements based on a Combobox selection.

Need help?  [![Get help on Codementor](https://cdn.codementor.io/badges/get_help_github.svg)](https://www.codementor.io/copperstarconsulting?utm_source=github&utm_medium=button&utm_term=copperstarconsulting&utm_campaign=github)

# Quick Overview
The project allows you to select a fruit from a Combobox, and displays a fruit-specific editor depending on the selected type.

The fruit-specific editors are implemented as DataTemplates (in the /Resources/FruitTemplates.xaml file).  It's important to note that DataTemplates are type-specific, so there is a DataTemplate for Apples, and another for Oranges, and so on.  The pattern of separating the DataTemplates into a separate resource file allows us to reuse the templates throughout our application.


