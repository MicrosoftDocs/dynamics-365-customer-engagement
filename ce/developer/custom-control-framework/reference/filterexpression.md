# FilterExpression

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [filterexpression-description](includes/filterexpression-description.md)]

## conditions

The set of conditions associated with this filter.

**Type**: [ConditionExpression](conditionexpression.md)[]

## filterOperator

The operator used to combine conditions in this filter.

**Type**: `enum`

The `filterOperator` value is an enum with the following possible values

|Value|Member|
|--|--|
|0|And|
|1|Or|

## filters

Placeholder description

**Type**: [FilterExpression](filterexpression.md)[]<br />
**Optional**


### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)