package com.example.pimandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button botaoAbrirSobreHotel, botaoQuartos, botaoProdutos, botaoTurismo, botaoFinalizar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        botaoAbrirSobreHotel=findViewById(R.id.btnSobreHotel);

        botaoAbrirSobreHotel.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){

                Intent intent = new Intent(getApplicationContext(),SobreHotel.class);
                startActivity(intent);
            }
        });

        botaoFinalizar=findViewById(R.id.btnExit);

        botaoFinalizar.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                finishAffinity();
            }
        });

        botaoQuartos=findViewById(R.id.btnQuartos);

        botaoQuartos.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                Intent intent = new Intent(getApplicationContext(),Quartos.class);
                startActivity(intent);
            }
        });

        botaoProdutos=findViewById(R.id.btnProdutos);

        botaoProdutos.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                Intent intent = new Intent(getApplicationContext(),Produtos.class);
                startActivity(intent);
            }
        });

        botaoTurismo=findViewById(R.id.btnTurismo);

        botaoTurismo.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v){
                Intent intent = new Intent(getApplicationContext(),Turismo.class);
                startActivity(intent);
            }
        });

    }
}