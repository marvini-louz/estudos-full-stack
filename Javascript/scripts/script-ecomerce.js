const catalogo = [
    {
        id: 1,
        imagem: "https://images.unsplash.com/photo-1542291026-7eec264c27ff",
        marca: "Nike",
        nome: "Nike Air Max Pulse",
        valor: 899.9,
    },

    {
        id: 2,
        imagem: "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab",
        marca: "Adidas",
        nome: "Camiseta Essentials",
        valor: 129.9,
    },

    {
        id: 3,
        imagem: "https://images.unsplash.com/photo-1541099649105-f69ad21f3246",
        marca: "Puma",
        nome: "Moletom Urban Style",
        valor: 249.9,
    },

    {
        id: 4,
        imagem: "https://images.unsplash.com/photo-1514996937319-344454492b37",
        marca: "Vans",
        nome: "Tênis Old Skool Black",
        valor: 399.9,
    },

    {
        id: 5,
        imagem: "https://images.unsplash.com/photo-1491553895911-0055eca6402d",
        marca: "New Balance",
        nome: "NB 550 Classic",
        valor: 749.9,
    },

    {
        id: 6,
        imagem: "https://images.unsplash.com/photo-1523381210434-271e8be1f52b",
        marca: "Zara",
        nome: "Jaqueta Minimalista",
        valor: 319.9,
    },

    {
        id: 7,
        imagem: "https://images.unsplash.com/photo-1503341455253-b2e723bb3dbb",
        marca: "Converse",
        nome: "All Star Chuck Taylor",
        valor: 299.9,
    },

    {
        id: 8,
        imagem: "https://images.unsplash.com/photo-1512436991641-6745cdb1723f",
        marca: "Levi's",
        nome: "Calça Jeans Slim",
        valor: 279.9,
    },

    {
        id: 9,
        imagem: "https://images.unsplash.com/photo-1529139574466-a303027c1d8b",
        marca: "Oakley",
        nome: "Óculos Holbrook",
        valor: 599.9,
    },

    {
        id: 10,
        imagem: "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77",
        marca: "Under Armour",
        nome: "Tênis HOVR Phantom",
        valor: 689.9,
    },

    {
        id: 11,
        imagem: "https://images.unsplash.com/photo-1548883354-94bcfe321cbb",
        marca: "Lacoste",
        nome: "Polo Premium",
        valor: 359.9,
    },

    {
        id: 12,
        imagem: "https://http2.mlstatic.com/D_NQ_NP_753848-MLB104006924363_012026-O-tenis-corrida-masculino-fila-esportivo-racer-move-original.webp",
        marca: "Fila",
        nome: "Tênis Racer Move",
        valor: 329.9,
    },

    {
        id: 13,
        imagem: "https://images.unsplash.com/photo-1529139574466-a303027c1d8b",
        marca: "Ray-Ban",
        nome: "Óculos Round Metal",
        valor: 799.9,
    },

    {
        id: 14,
        imagem: "https://images.unsplash.com/photo-1483985988355-763728e1935b",
        marca: "Tommy Hilfiger",
        nome: "Camisa Casual Premium",
        valor: 289.9,
    },

    {
        id: 15,
        imagem: "https://images.unsplash.com/photo-1460353581641-37baddab0fa2",
        marca: "Asics",
        nome: "Gel Quantum 360",
        valor: 949.9,
    },
];

for (const indexProduct of catalogo) {
    const productBox = `
    <div class="catalogo__lista__produtos">
        <div id="image-box">
            <img src="${indexProduct.imagem}" alt="Produto ${indexProduct.id}" />
        </div>
        <div>
            <p>${indexProduct.marca}</p>
            <p>${indexProduct.nome}</p>
            <p>$${indexProduct.valor.toFixed(2)}</p>
        </div>
        <button>Adicionar</button>
    </div>
    `;

    document.getElementById("product-list").innerHTML += productBox;
}
