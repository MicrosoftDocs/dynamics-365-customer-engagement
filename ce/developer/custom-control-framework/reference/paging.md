# Paging

<!-- IDataSetExposedPaging  -->


[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [paging-description](includes/paging-description.md)]


## firstPageNumber

Number of first page

**Type**: `number`

## hasNextPage

Whether the result set can be paged backwards.

**Type**: `boolean`

## hasPreviousPage

Whether the result set can be paged backwards.

**Type**: `boolean`

## lastPageNumber

Number of last page

**Type**: `number`

## pageSize

The number of records per page

**Type**: `number`

## totalResultCount

Total number of results on the server for the current query.

**Type**: `number`

## Methods

|Method | Description | 
| ------|-------------|
|[loadNextPage](paging/loadnextpage.md)|[!INCLUDE [loadnextpage-description](paging/includes/loadnextpage-description.md)]|
|[loadPreviousPage](paging/loadpreviouspage.md)|[!INCLUDE [loadpreviouspage-description](paging/includes/loadpreviouspage-description.md)]|
|[reset](paging/reset.md)|[!INCLUDE [reset-description](paging/includes/reset-description.md)]|
|[setPageSize](paging/setpagesize.md)|[!INCLUDE [setpagesize-description](paging/includes/setpagesize-description.md)]|

### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)
