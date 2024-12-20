'use client'

import type { PropsWithChildren } from 'react'
import { YStack } from 'tamagui'

import { MainBottomTabs } from './MainBottomTabs'
import { MainHeader } from './MainHeader'

export function MainLayoutWeb({ children }: PropsWithChildren<{}>) {
  return (
    <YStack flex={1} position='relative'>
      <MainHeader />
      {children}
      <MainBottomTabs />
    </YStack>
  )
}

export default MainLayoutWeb
