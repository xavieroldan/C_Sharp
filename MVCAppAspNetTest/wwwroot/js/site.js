var urlServer = "https://localhost:44348/";

function validateUser()
{
    
    var name = document.getElementById("name_user").value;    
    var pass = document.getElementById("password_user").value;
    var myObj = { name: name, password: pass }; 
    alert("Name:" + name + "/password:" + pass + "/object:" + myObj);
    alert("XD");

    $.ajax({
        type: "POST",
        url: urlServer + "/Login/LoginUser",
        data: formData,
        success: function(data)
        {
            alert("in success");
            return myObj;
        },
        dataType: "json",
        contentType: "application/json",
        //error: function(xhr, ajaxOptions, thrownError)
        //{
        //    alert"error";
        //}

    });
}

