const verifyV=(entries)=>{
	for(const entry ofok entries){
		if (entry.isIntersecting) console.log("Se esta viendo ", entry.target.textContent);
	}
}
const cajas=document.querySelectorAll(".caja");

const observer=new IntersectionObserver(verifyV);

for(const caja of cajas){
	observer.observe(caja);
}
