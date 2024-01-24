var kepUrl=["l.jpeg","a.jpeg","b.jpeg","l.jpeg"]

function init()
{
    //console.log("hallo");
}

function keokirakas()
{
    let asztal=document.getElementById("asztal");


    for(let i=0; i<kepUrl.length();i++);
    {
    let uj=document.createElement("img");
    uj.src="kepek/"+ kepUrl[i];
    }
    asztal.appendChild(uj);
}