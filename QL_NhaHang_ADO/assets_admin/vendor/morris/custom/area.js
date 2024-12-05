// Morris Area Chart
Morris.Area({
	element: "areaChart",
	data: [
		{ y: "2017", a: 10, b: 5, c: 2 },
		{ y: "2018", a: 40, b: 15, c: 8 },
		{ y: "2019", a: 15, b: 50, c: 25 },
		{ y: "2020", a: 40, b: 15, c: 7 },
		{ y: "2021", a: 20, b: 30, c: 20 },
		{ y: "2022", a: 35, b: 15, c: 20 },
		{ y: "2023", a: 20, b: 15, c: 51 },
	],
	xkey: "y",
	ykeys: ["a", "b", "c"],
	behaveLikeLine: !0,
	pointSize: 0,
	labels: ["Sales", "Expenses", "Projects"],
	pointStrokeColors: [
		"#0068ff",
		"#3386ff",
		"#4d95ff",
		"#66a4ff",
		"#80b4ff",
		"#99c3ff",
		"#b3d2ff",
		"#cce1ff",
	],
	gridLineColor: "#cccccc",
	lineColors: [
		"#0068ff",
		"#3386ff",
		"#4d95ff",
		"#66a4ff",
		"#80b4ff",
		"#99c3ff",
		"#b3d2ff",
		"#cce1ff",
	],
	gridtextSize: 10,
	fillOpacity: 0.4,
	lineWidth: 0,
	hideHover: "auto",
	resize: true,
	redraw: true,
});