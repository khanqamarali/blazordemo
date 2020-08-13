function my_callToCShap()
{
    DotNet.invokeMethodAsync("blazorclient1", "CallfromJavaScript")
        .then(result => {
            alert(result);
        });
}