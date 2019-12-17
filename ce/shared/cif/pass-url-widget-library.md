# Pass a Dynamics 365 URL to a widget library

To access the Dynamics 365 Channel Integration Framework (CIF) APIs, you need to load the `msdyn_cilibrary.js` file inside your communication widget. Since the widget is in a different domain, this library needs to know what Dynamics 365 domain it should talk to. For this reason you need to pass your Dynamics 365 instance URL to the widget library.

> [!IMPORTANT]
> For any organization hosted in Government Community Cloud(GCC) or Microsoft Cloud Germany, the provider domain should either reside inside the respective cloud or it should be whitelisted for access from within that cloud.

There are two ways to pass a Dynamics 365 URL to a widget library.

## 1. Add attributes to the script tag

The widget provider has to add the following attributes to the script tag that loads `msdyn_cilibrary.js` to pass the Dynamics 365 domain:

`data-cifid: CIFMainLibrary` <br />
`data-crmurl: <CRM domain name>`

### Example

```html
<script type="text/javascript" src="https://crmorg.crm.dynamics.com/webresources/Widget/msdyn_ciLibrary.js" onload="ciLoadDone();" data-crmurl="https://crmorg.crm.dynamics.com" data-cifid="CIFMainLibrary">
</script>
```

## 2. Add a URL parameter

Another method is to pass a `ucilib` parameter in the landing URL, like `ucilib=https://crmorg.crm.dynamics.com/webresources/Widget/msdyn_ciLibrary.js`.

### Example

`https://widget.domain.com?ucilib=https://crmorg.crm.dynamics.com/webresources/Widget/msdyn_ciLibrary.js`

## See also

[Configure a channel provider for your Dynamics 365 organization](configure-channel-provider-channel-integration-framework.md)<br />
[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)<br />
[Add a Channel Integration Framework solution as a dependent solution](add-cif-solution-dependent-solution.md)<br />
[Authenticate channel users to the channel (widget)](authenticate-channel-users.md)
