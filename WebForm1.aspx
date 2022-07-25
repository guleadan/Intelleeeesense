<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Intellisense.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Adan Motors</title>
    <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    <script>
        function DisplayOptions() {
            var inputVal = document.getElementById("carName").value();
            var num = inputVal.length;
            $.ajax({
                url: 'WebForm1.aspx/GenerateList',
                type: 'post',
                data: JSON.stringify({ "txt": inputVal, "length": num }),
                contentType: 'application/json',
                async: false,
                success: function (data) {
                    var inner = document.getElementById("options");
                    inner.innerHTML = data.d;
                }
            });

        }
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label runat="server"> Welcome to Adan Motors!</label><br />
            <input type="text" id="carName" placeholder="Enter your desired car name here" onkeypress="DisplayOptions()" />
            <p runat="server" id="options"></p>
        </div>
    </form>
</body>
</html>
