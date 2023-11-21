The `onclicktoact` event invoked when user selects the outbound communication (ClickToAct) field in a form.

You can also write custom controls to raise the Channel Integration Framework ClickToAct window event and pass any event data as the business requirement.

## eventData

The `onclicktoact` event takes the following eventData:

| eventData | Example |
|-----------|---------|
| ```{"value": <field_value>, "name": <field_name>, "format": <field_type>, "entityLogicalName": <entity_logical_name>}``` | ```{"value": "123456789", "name": "mobilephone", "format": "phone", "entityLogicalName": "contact"}``` |