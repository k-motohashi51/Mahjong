﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingJudgment : MonoBehaviour
{
    int playerTurn = 0;
    //クラスの中に入れるべきなのかどうかもわからない.ファイルすら分けるべきかも
    //向聴数(あがりやリーチまでの数)

    //国士無双の場合

    //任意の手牌とその次とが対子どうかを調べて真偽を返す
    int CheckToitu(int[][] tehai, int i) {
        int count = 0;//連続何枚繋がってるか
        if (tehai[playerTurn][i] == tehai[playerTurn][i + 1]) {
            count++;
            if (tehai[playerTurn][i + 1] == tehai[playerTurn][i + 2]) {
                count++;
            }
            if (tehai[playerTurn][i + 2] == tehai[playerTurn][i + 3]) {
                count++;
            }
        }
        return count;
    }
    int SyantenKokusiMusou(int[][] tehai) {
        int syanten = 13;
       
        for (int i = 0; i < 13; i++) {
            //手牌の種類(一九字牌)を数える
            if (CheckToitu(tehai, i) == 1) syanten--;
            if(tehai[playerTurn][i] == (pai[4] || pai[5] || pai[][1] || pai[][9]))
                syanten--;
        }
        return syanten;//向聴数を返す
    }
    //七対子の場合

    int checkKind(int[][] tehai) {
        int kindCount = 0;//種類の数
        for (int i = 0; i < 12; i++) {
            if (tehai[playerTurn][i] != tehai[playerTurn][i + 1]) {
                kindCount++;
            }
        }
    return kindCount+1;
    }
        //牌の種類を求める必要がある
    int SyantenTitoi(int[][] tehai) {
        int syanten = 0;
        int kind = 0;
        int toitu = 0;
        for(int i = 0; i < 12; i++) {
            if(CheckToitu(tehai,i) == 1) {
                toitu++;
            }
        }
        kind = checkKind(tehai);
        syanten = 6 - toitu+(7 - kind);
        return syanten;
    }

    int checkTatu(int[][] tehai) {
        int tatu = 0;
        for(int i = 0; i < 13; i++) {

        }
        return tatu;  
    }
        //一般の場合
    int SyantenGeneral(int[][] tehai) {
        int syanten = 0;

        return syanten;
    }
    }
