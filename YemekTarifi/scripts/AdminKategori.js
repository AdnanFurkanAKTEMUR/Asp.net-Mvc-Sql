const gosterBtn=document.querySelector('.goster-gizle');
const gosterBtn2=document.getElementById('goster-gizle');


gosterBtn.addEventListener('click',gosterGizle);
gosterBtn2.addEventListener('click',gosterGizle2);



function gosterGizle(e){
    e.preventDefault();
    const dataList=document.querySelector('.kategoriler-datalist');
    
    if(gosterBtn.textContent=="Göster"){
        gosterBtn.textContent="Gizle";
        dataList.style.display="table";
    }
    else{
        gosterBtn.textContent="Göster";
        dataList.style.display="none";
    }
}

function gosterGizle2(e){
    e.preventDefault();
    const table=document.querySelector('.kategoriler-tbl');
    
    if(gosterBtn2.textContent=="Göster"){
        gosterBtn2.textContent="Gizle";
        table.style.display="table";
    }
    else{
        gosterBtn2.textContent="Göster";
        table.style.display="none";
    }
}