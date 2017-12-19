---
title: "Interact with HTTP(S) resources asynchronously | MicrosoftDocs"
description: "You should interact with HTTP(s) resources asynchronously."
ms.date: 11/30/2017
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f4060ac9-c9f7-4719-9183-9cf05f64d3f7
author: "mhuguet"
ms.author: "michu"
manager: "austinj"
---
# Interact with HTTP(S) resources asynchronously

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-8-2-0-online.md)]
- [!include[](../../includes/pn-crm-2016-onprem.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Performance

**Impact potential**: High

<a name='symptoms'></a>

## Symptoms

Synchronous requests block the execution of other script, which can cause the following:

- Unresponsive client pages
- Slow client interaction
- The browser "hangs" in an unresponsive state

<a name='guidance'></a>

## Guidance

Interact asynchronously with HTTP(S) resources whenever possible. Users should notice improvements in the actual page load time or the perceived speed of the page loading. The responsiveness of the page should also increase.

The following are options available in modern browsers for interacting with services asynchronously:

   > [!NOTE]
    > Adding asynchronous interactions requires a different style of design than synchronous interactions. Multiple script paths can be in process simultaneously, which means that more thought is necessary to ensure that the page flow and integrity are correct at all times. For example, many times measures should be put in place to ensure that controls are not enabled until all dependent service calls have returned. Taking a few additional steps can ensure a more enjoyable user experience.

- [`XMLHttpRequest`](https://developer.mozilla.org/docs/Web/API/XMLHttpRequest) with the async parameter omitted or set to true

  ```javascript
  // Missing the async parameter, which is the third parameter. It defaults to true, which is the desired value.
  var requestXhr = new XMLHttpRequest();
  requestXhr.open('GET', '/test/test.txt');

  // Explicitly setting the async parameter.
  requestXhr.open('GET', '/test/test.txt', true);
  ```

- Either of the aforementioned initiated within a [Web Worker](https://developer.mozilla.org/docs/Web/API/Web_Workers_API) context

- [`Fetch`](https://developer.mozilla.org/docs/Web/API/Fetch_API) API usage

> [!WARNING]
> Before proceeding with this option, ensure that support is available for the browsers in which are used to interact with your customizations. Review the [`Fetch`](https://developer.mozilla.org/docs/Web/API/Fetch_API) documentation's **Browser compatibility** section.

- [`jQuery`](https://www.jquery.com) [`ajax` function](http://api.jquery.com/jquery.ajax/) with the async parameter being left alone or set to true

> [!WARNING]
> Usage of jQuery is not the preferred approach as it adds a dependency to an external library and is not recommended in interacting with the product. Refer to [Use of jQuery](https://msdn.microsoft.com/library/hh771584.aspx?#BKMK_UsingjQuery) for more information.

  ```javascript
  // jQuery example that is missing the async parameter, which is the third parameter. It defaults to true, which is the desired value.
  var requestXhr = new XMLHttpRequest();
  var requestAjaxDefault = $.ajax({ url: '/test/test.txt' });

  // jQuery example explicitly setting the async parameter to true.
  var requestAjax = $.ajax({ async: true, url: '/test/test.txt' });
  ```

<a name='problem'></a>

## Problematic patterns

There are multiple ways to interact with the server or request resources. Common approaches that allow for synchronous communications include the following:

- Usage of the `XMLHttpRequest` object (aside from being executed within the context of a `Worker`), passing in `false` for the value of the `async` parameter for the `open` function call

  ```javascript
  var requestXhr = new XMLHttpRequest();

  // Explicitly setting the async parameter to false or supplying a variable with a value of false will force this as a synchronous call.
  requestXhr.open('GET', '/test/test.txt', false);
  ```

- Usage of the [`jQuery`](https://www.jquery.com) [`ajax` function](http://api.jquery.com/jquery.ajax/), passing in `false` for the value of the `async` parameter

  ```javascript
  // Explicitly setting the async parameter to false or supplying a variable with a value of false will force this as a synchronous call.
  var requestAjax = $.ajax({ async: false, url: '/test/test.txt' });
  ```

- Specific to interactions with the Dynamics 365 services, there are JavaScript libraries that provide explicit operations for common interactions with the product. Common libraries include (but are not limited to): [`SDK.REST.js`](https://msdn.microsoft.com/en-us/library/gg334427(v=crm.7).aspx#BKMK_SDKREST), [`SDK.Soap.js`](https://code.msdn.microsoft.com/sdksoapjs-9b51b99a) and [`XrmServiceToolkit.js`](https://github.com/XrmServiceToolkit/XrmServiceToolkit).
  - For these, there are some functions that only support synchronous operations, others require passing in a callback function as a parameter in order to set async to true. The default behavior for most is to set the underlying async parameter to `false` for the open call of the `XMLHttpRequest` object.

<a name='additional'></a>

## Additional information

### Performance

Traditionally, a browser interprets script on a single thread. If that thread is being used to execute a long-running process synchronously, the browser is likely to stop responding to the user's interactions waiting on it to complete. Synchronous calls also remove the ability to perform more than one interaction simultaneously, forcing all calls to be serial in nature. In many cases, this leads to the frustration of your users. Optimize user responsiveness by incorporating asynchronous service calls.

> [!NOTE]
> An acceptable alternative approach is to leverage a [web worker](https://developer.mozilla.org/docs/Web/API/Worker). This modern feature allows for a background thread to be employed. In cases where synchronous calls are being executed within a worker, these are actually processed asynchronous.

### Browser support

The specification for `XMLHttpRequest` states that synchronous usage is being removed from the standard as is now deprecated. It is encouraged that browsers warn when synchronous executions are performed. Currently, browsers are only presenting warnings, but an InvalidAccessError exception may be thrown in the future when a value of false is passed to the async parameter. Modern browsers have declared synchronous requests executed on the main thread as deprecated.

> [!NOTE]
> Modern APIs are being introduced that will no longer provide an option for synchronous operations. Refer to documentation of the [Fetch API](https://developer.mozilla.org/docs/Web/API/Fetch_API) for more details.

### window.setTimeout

While including script blocks as a parameter to the `window.setTimeout` function does break the normal synchronous flow of the page execution, it does not accomplish parallel processing.

```javascript
window.setTimeout(
    function () {
        var oReq = new XMLHttpRequest();
        oReq.open('GET', '/test/action', false);
    }, 0);
```

The approach in this example, still processes on the main browser UI thread locking the browser.

<a name='seealso'></a>

## See also

[About Native XMLHTTP](https://msdn.microsoft.com/library/ms537505)<br />
[XMLHttpRequest](https://docs.microsoft.com/microsoft-edge/dev-guide/performance/xmlhttprequest)<br />
[XMLHttpRequest specification (with synchronous deprecation statement)](https://xhr.spec.whatwg.org/#the-open()-method)<br />
[Fetch API specification](https://fetch.spec.whatwg.org/#fetch-api)<br />
[Fetch API](https://developer.mozilla.org/docs/Web/API/Fetch_API)<br />
[Web worker specification](https://html.spec.whatwg.org/multipage/workers.html)<br />
[Web worker](https://developer.mozilla.org/docs/Web/API/Worker)
