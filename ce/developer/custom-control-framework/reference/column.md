# Column

<!-- IDataSetExposedColumn  -->

[!INCLUDE [column-description](includes/column-description.md)]

## alias

The alias of this column.

**Type**: `string`

## dataType

The data type of this column's values.

**Type**: `string`

## disableSorting

Whether the column must disable sorting

**Type**: `boolean`<br />
**Optional**

## displayName

Localized display name for the column

**Type**: `string`

## imageProviderFunctionName

The name of the function that provides an image for the column.

**Type**: `string`<br />
**Optional**

## imageProviderWebresource

The column web resource name.

**Type**: `string`<br />
**Optional**

## isHidden

The column visibility state.

**Type**: `boolean`<br />
**Optional**

## isPrimary

Whether the column is the primary attribute.

**Type**: `boolean`<br />
**Optional**

## name

Name of the column, unique in this data set.

**Type**: `string`

## order

The column order for the layout.

**Type**: `number`

## visualSizeFactor

The configured size factor for this column relative to other columns in the data set. 

**Type**: `number`

### Remarks
By default columns have a size factor of 1.0, but the system customizer or user can make some columns larger (e.g., 1.5) or smaller (e.g., 0.75).


### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)